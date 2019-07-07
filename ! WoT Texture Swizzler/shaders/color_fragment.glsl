//color
#version 130
uniform sampler2D colorMap;
uniform vec4 mask;

in vec2 texCoord;
void main()
{
    vec4 color = texture2D(colorMap, texCoord);

    color.r *= mask.r;
    color.g *= mask.g;
    color.b *= mask.b;
    color.a *= mask.a;
    if ( mask.a == 0.0 ){ color.a = 1.0; }
	if ( length(mask.rgb) == 0.0) color.rgb = vec3(1.0);
    gl_FragColor = color;
}           
    
 