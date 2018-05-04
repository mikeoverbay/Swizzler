//swizzel vertex

#version 130
#extension GL_EXT_gpu_shader4 : enable

uniform int r_mask;
uniform int g_mask;
uniform int b_mask;
uniform int a_mask;
uniform int convert_RGB_NM;
uniform int flip_y;
uniform int flip_x;
uniform int use_alpha_fill;
uniform int use_alpha_blend;
uniform int alpha_multiply;
uniform int use_mask;
uniform int mask_function;
uniform int mask_texture_channels;
uniform float alpha_value;
uniform float mask_mix;
uniform sampler2D colorMap_in; // current_texture_swizz
uniform sampler2D colorMap_out; // temp_image2
uniform sampler2D mask_texture; // mask_texture
varying vec2 texCoord;

void main() {
    vec4 color_out = texture2D(colorMap_out, texCoord);
    vec4 color_in = texture2D(colorMap_in, texCoord);
    float r_r, r_g, r_b, r_a ;
    float g_r, g_g, g_b, g_a ;
    float b_r, b_g, b_b, b_a ;
    float a_r, a_g, a_b, a_a ;
    //convert bitmask to 0.0 or 1.0 floats.
    r_r = float(r_mask & 1);
    r_g = float(( r_mask & 2) /2 );
    r_b = float(( r_mask & 4) /4 );
    r_a = float(( r_mask & 8) /8 );
    g_r = float( g_mask & 1 );
    g_g = float(( g_mask & 2) /2 );
    g_b = float(( g_mask & 4) /4 );
    g_a = float(( g_mask & 8) /8 );
    b_r = float( b_mask & 1 );
    b_g = float(( b_mask & 2) /2 );
    b_b = float(( b_mask & 4) /4 );
    b_a = float(( b_mask & 8) /8 );
    a_r = float( a_mask & 1 );
    a_g = float(( a_mask & 2) /2 );
    a_b = float(( a_mask & 4) /4 );
    a_a = float(( a_mask & 8) /8 );
    //red
    color_out.r = mix(color_out.r, color_in.r , r_r);
    color_out.g = mix(color_out.g, color_in.r , r_g);
    color_out.b = mix(color_out.b, color_in.r , r_b);
    color_out.a = mix(color_out.a, color_in.r , r_a);
    //green
    color_out.r = mix(color_out.r, color_in.g , g_r);
    color_out.g = mix(color_out.g, color_in.g , g_g);
    color_out.b = mix(color_out.b, color_in.g , g_b);
    color_out.a = mix(color_out.a, color_in.g , g_a);
    //blue
    color_out.r = mix(color_out.r, color_in.b , b_r);
    color_out.g = mix(color_out.g, color_in.b , b_g);
    color_out.b = mix(color_out.b, color_in.b , b_b);
    color_out.a = mix(color_out.a, color_in.b , b_a);
    //alpha
    color_out.r = mix(color_out.r, color_in.a , a_r);
    color_out.g = mix(color_out.g, color_in.a , a_g);
    color_out.b = mix(color_out.b, color_in.a , a_b);
    color_out.a = mix(color_out.a, color_in.a , a_a);
    if (convert_RGB_NM == 1) 
    {
        vec2 co = color_out.ag;
        color_out.rg  = co;
        color_out.b = sqrt(1.0 - (color_out.r * color_out.r) + (color_out.g * color_out.g));
		if (flip_y == 1) color_out.y *= -1.0;
		if (flip_x == 1) color_out.x *= -1.0;
        color_out.a = 1.0;
    }

    gl_FragColor = color_out;
    if (use_alpha_fill == 1)
    {
        if (alpha_multiply == 0) gl_FragColor.a = alpha_value;
        if (alpha_multiply == 1) gl_FragColor.a *= alpha_value;
    }


    color_out = gl_FragColor;
    vec4 color_mask = color_out;
    vec4 m;
    m.r = float((mask_texture_channels & 1)/1);
    m.g = float((mask_texture_channels & 2)/2);
    m.b = float((mask_texture_channels & 4)/4);
    m.a = float((mask_texture_channels & 8)/8);
    vec4 clean_mask = texture2D(mask_texture, texCoord);
    vec4 mask_t = vec4(0.0);
    float t_alpha;
    if (use_alpha_blend == 1){
        t_alpha = clean_mask.a;
    }
else{
        t_alpha      = 1.0;
        clean_mask.a = 1.0;
    }


    if (clean_mask.r* clean_mask.a > 0.0) {
        mask_t.r = 1.0;
    }

    if (clean_mask.g* clean_mask.a > 0.0) {
        mask_t.g = 1.0;
    }

    if (clean_mask.b* clean_mask.a > 0.0) {
        mask_t.b = 1.0;
    }

    if (clean_mask.a* clean_mask.a > 0.0) {
        mask_t.a = 1.0;
    }

    if (clean_mask.a* clean_mask.a > 0.0) {
        mask_t.a = 1.0;
    }
  
vec4 tmix ;
    if (use_mask==1)
    {
        if (mask_function == 0) //Replace
            {
            color_mask = mix(color_out, clean_mask,  m * clean_mask.a);
        }

        if (mask_function == 1)// subtract
            {
            color_mask = mix(color_out,color_out - clean_mask,  m * clean_mask.a);
        }

        if (mask_function == 2) // mask
            {
            if (use_alpha_blend == 0)
                {
                tmix       = mix(vec4(0.0), vec4(01.0) ,  mask_t);
                // create invert mix
                color_mask = color_out * tmix;
                // tmix applies mask
                }else{
                color_mask = mix( vec4(0.0), color_out,  mask_t * clean_mask.a);
                // blend mode mask
                t_alpha    = 1.0 - t_alpha;
                // need to flip alpha for blending to work correctly
                }                
            }
        if (mask_function == 3) // mask invert
            {
            color_mask = mix(color_out, color_out * (vec4(1.0) -mask_t),  mask_t);
        }

        if (use_alpha_blend == 1)
        {
            gl_FragColor = mix(color_out, color_mask, t_alpha * vec4(mask_mix) * m);
        }
else{
            gl_FragColor = mix(color_out, color_mask, m * vec4(mask_mix));
        }

        
   }

}
