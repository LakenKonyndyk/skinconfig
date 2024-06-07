#ifdef EMBEDDED
varying vec2 fsTex;
#else
#extension GL_ARB_separate_shader_objects : enable
layout(location=1) in vec2 fsTex;
layout(location=0) out vec4 target;
#endif

uniform sampler2D mainTex;
uniform float hiddenCutoff;
uniform float hiddenFadeWindow;
uniform float suddenCutoff;
uniform float suddenFadeWindow;

// The OpenGL standard leave the case when `edge0 >= edge1` undefined,
// so this function was made to remove the ambiguity when `edge0 >= edge1`.
// Note that the case when `edge0 > edge1` should be avoided.
float smoothstep_fix(float edge0, float edge1, float x)
{
    if(edge0 >= edge1)
    {
        return x < edge0 ? 0.0 : x > edge1 ? 1.0 : 0.5;
    }

    return smoothstep(edge0, edge1, x);
}

void main()
{	
	
}