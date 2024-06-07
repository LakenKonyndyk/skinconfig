#extension GL_ARB_separate_shader_objects : enable
layout(points) in;
layout(triangle_strip, max_vertices = 4) out;

// Input
in gl_PerVertex
{
	vec4 gl_Position;
} gl_in[1];
layout(location=1) in vec4 inColor[1];
layout(location=2) in vec4 inParams[1];

// Output
out gl_PerVertex
{
	vec4 gl_Position;
};
layout(location=1) out vec4 fsColor;
layout(location=2) out vec2 fsTex;

uniform mat4 proj;
uniform mat4 camera;
uniform mat4 billboard;

void main()
{
	
}	