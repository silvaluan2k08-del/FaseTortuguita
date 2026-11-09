Worn Red Barrel - Documentation

Compatibility: Unity 6000.6.1f1, Universal Render Pipeline 17.6.0.

Setup
1. Import Worn_Red_Barrel_Unity_URP.unitypackage into a Unity URP project.
2. Drag Assets/Worn_Red_Barrel/Prefabs/Worn_Red_Barrel.prefab into your scene.
3. The package includes a demo in Scenes/Overview.unity. Its floor and lights are presentation objects.
4. Use your project's URP pipeline, or select Settings/BarrelPipeline in Project Settings > Graphics and the applicable Quality level to reproduce the demo.

Contents
One closed steel barrel with weathered red paint and shallow dents. Three physical parts (shell and two sealed bungs) are combined into one native visual Mesh asset, one material and one prefab. Diameter 0.58 m, height 0.88 m; origin at ground/base centre. Root position and rotation are zero; scale is one.
Visual geometry: 4,876 triangles and 2,672 Unity vertices. Collision: a separate 16-sided convex cylinder mesh, 64 triangles, covering the barrel with up to approximately 6 mm radial allowance. The prop is marked Static. No Rigidbody or runtime interaction is supplied.

PBR textures
Three textures, each 2048 x 2048: BaseColor (sRGB), OpenGL Normal (Normal Map importer), and MetallicSmoothness (linear, sRGB disabled). Metallic is in red; Smoothness is in alpha and equals 1 minus Roughness. On URP/Lit, choose Metallic Alpha as Smoothness source and use multiplier 1. No AO texture is supplied. All texture and mesh dependencies are inside the asset folder; URP itself is a Unity Package dependency.

Limitations
Built-in and HDRP are not validated. No rig, animation clips, LOD variants, explosion behavior, liquid simulation, opening lid or navigation logic are included. The two plugs are part of the closed prop, not interactive objects. Performance on target game hardware must be measured in your own scene.

Creation process
Created using an AI coding assistant through Blender Python and procedural material baking. The selected design reference was AI-generated. Preview images render the supplied geometry. No photogrammetry, hand-painted textures or manual sculpting is claimed.
