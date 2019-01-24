// Equirectangular Fragment Prog

#version 130

uniform sampler2D txr; // texture
uniform vec2 size; // texture size X,Y

in float wpos; // section position
in float parallel; // longitude parallel

in vec2 texCoord; // 0 to 1, 0 to -1
in vec3 n; // n = surface normal


void main() {

    vec2 center = vec2(0.5, -0.5) / size; // not really needed
    vec2 tc = texCoord;

    // scale x by cos(latitude)
    float u1 = wpos*cos(asin(n.y));

	// add to current parallel and scale to 0.0 to 1.0 range
    float u = (u1+ parallel)/size.x;

    float v = tc.y;

    gl_FragColor = texture2D(txr, vec2(u,v) + center); // write to buffer

}

