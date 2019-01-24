// Equirectangular Vertex Prog

#version 130

uniform vec2 size; // texture size X,Y

out float wpos; // section position
out float parallel; // longitude parallel

out vec2 texCoord;
out vec3 n;

void main(){

    n = gl_Normal;

    texCoord = gl_MultiTexCoord0.xy;

    parallel = gl_MultiTexCoord1.x;
    wpos = gl_MultiTexCoord1.y;
    
    vec2 tc;

    tc.x = (wpos+parallel)/size.x; 

    tc.y = texCoord.y;

    vec4 vt;
    vt.xy = tc*2.0-1.0;// scale to -1.0 to 1.0
    gl_Position =  vt;
    }