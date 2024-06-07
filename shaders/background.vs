#extension GL_ARB_separate_shader_objects : enable

layout(location=0) in vec2 inPos;
layout(location=1) in vec2 inTex;

out gl_PerVertex
{
	vec4 gl_Position;
};
layout(location=1) out vec2 texVp;

uniform ivec2 viewport;

void main()
{
	
}