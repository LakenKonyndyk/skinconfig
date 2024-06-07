#version 330
#extension GL_ARB_separate_shader_objects : enable

layout(location=1) in vec2 fsTex;
layout(location=0) out vec4 target;

uniform sampler2D frame;
uniform sampler2D jacket;
uniform float time;
uniform float selected;

void main()
{
	
}