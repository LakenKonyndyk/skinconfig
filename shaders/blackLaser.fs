#ifdef EMBEDDED
varying vec2 fsTex;
varying vec4 position;
#else
#extension GL_ARB_separate_shader_objects : enable
layout(location=1) in vec2 fsTex;
layout(location=0) out vec4 target;
in vec4 position;
#endif

uniform sampler2D mainTex;

void main()
{	
    
}