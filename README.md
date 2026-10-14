# Unity Textbook Classwork
## Ch 1 & 2
- Open `Ch2` Scene
## Ch 5
- Open `Ch5` Scene
- Play it
- Go to console to see results
## Ch 6
- Open `Ch6` Scene
- Play it
- Use controls to see functionality
## Ch 7, 8 & 9
- Open `Ch7-9` Scene
- Play it
- Use controls to move, look, and shoot
- Enemies spawn in waves, path around the walls to the base, and chase and shoot the player when in their view
- Select `ScoreManager` in the Hierarchy to see the score go up with each kill
- Killing all enemies after the waves end loads the `Win` Scene
- The player or the base running out of life loads the `Lose` Scene
- Turn on Gizmos in the Scene view to see the enemy sight and attack ranges
## Ch 3 & 4
- Open `Ch 3, 4, 10` Scene
- Select `Terrain` to see the 200 x 200 terrain with mountains around the edges, a moat, and a flat hilltop, painted with grass, dirt, and rock layers
- Select `Plane` to see the ProBuilder base with its extruded walls, beveled edges, and pit
- Select `Base` to see the modular base built from the Sci-Fi Styled Modular Pack that replaces the ProBuilder base
- `Polyart_Mesh` is the imported robot character, with the `Capsule` next to it as a size reference
## Ch 10
- Open `Scene10` Scene
- This combines the `Ch 3, 4, 10` Scene with the `Ch7-9` gameplay, with the primitives replaced by models (the robot for the player and enemies, the modular base for the floor and walls, and a generator for the base)
- Play it
- Use controls to move, look, and shoot, same as `Ch7-9`
- Select the `Cube` and move the Alpha Clipping Threshold on its material to see it disintegrate
- The water in the moat uses the `Water` Shader Graph, with scrolling, blended textures, transparency, and moving ripples
- Select `Plane (1)` and look at `WaterMaterial` to see the water material
