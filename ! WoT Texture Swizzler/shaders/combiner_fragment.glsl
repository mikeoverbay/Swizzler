//combiner fragment

#version 130
#extension GL_EXT_gpu_shader4 : enable

uniform int r_mask;
uniform int g_mask;
uniform int b_mask;
uniform int a_mask;

uniform float r_level;
uniform float g_level;
uniform float b_level;
uniform float a_level;

uniform sampler2D texture_1;
uniform sampler2D texture_2;
uniform sampler2D texture_3;
uniform sampler2D texture_4;
in vec2 texCoord;
out vec4 FragColor;
vec4 mask_it(int mask, vec4 c_in, float color){
    vec4 c_o = c_in;
    switch (mask){
        case 0:
        return c_in;
        break;
        case 1:
        c_o.r = color;
        break;
        case 2:
        c_o.g = color;
        break;
        case 4:
        c_o.b = color;
        break;
        case 8:
        c_o.a = color;
    }
    return c_o;
}


void main(void){
    float r = texture2D(texture_1,texCoord.st).r * r_level;
    float g = texture2D(texture_2,texCoord.st).r * g_level;
    float b = texture2D(texture_3,texCoord.st).r * b_level;
    float a = texture2D(texture_4,texCoord.st).r * a_level;
    vec4 color_out = vec4(0.0, 0.0, 0.0, 1.0);
    color_out = mask_it(r_mask,color_out,r);
    color_out = mask_it(g_mask,color_out,g);
    color_out = mask_it(b_mask,color_out,b);
    color_out = mask_it(a_mask,color_out,a);
    FragColor = color_out;
}

