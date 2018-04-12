//maskGen
#version 130
uniform sampler2D colorMap;

in vec2 texCoord;
void main()
{
    vec4 color = texture2D(colorMap, texCoord);
	float alpha = clamp(color.r+color.g+color.b,0.0,1.0);
    color.a = alpha;
    gl_FragColor = color;
}           
    
