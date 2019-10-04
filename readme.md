# SpaceGame


An homage to Space Invaders and the whole genre of asteroid space shooter games.

Space Invaders was the first sensational video game. We are inspired to create the first type of this kind of game for VR.

We want to preserve the fun arcade elements, like transitions on losing, restarting to the beginning (even though we will have rogue like elements), constant action, the timeless elements










<p> Move these game settings somewhere else eventually:


# Camera

pos - 0, 10, -5.35
rotation 43.25, 0, 0


Starfield Skybox

OVRCameraRig in scene for VR




For direct on view:

pos: 0, 1.75, -4.5
rotation: 3.37, 0, 0


Score text mesh position, should be in world space

pos: 560, 240, -337
rotation: y 40


VR Screenshake shader code:

http://www.zulubo.com/gamedev/2019/1/5/vr-screen-shake-the-art-of-not-throwing-up



Text Mesh Overlay Score

515, 182, -530
width 200, height 50

font size 1

for panel
23900, -29564, -24591

scale
1

# To get the right trigger on the XBOX One controller:

void Update ()
	{
		if ((Input.GetButton("Fire1") || Mathf.Round(Input.GetAxisRaw("PrimaryAttack")) > 0) && Time.time > nextFire) 
		
 
in player controller


In project settings, input settings should be:

Name: "PrimaryAttack"

Everything zeroed out, except from bottom up: 1, 0, 0


snap on, invert off

Type: Joystick Axis
Axis: 3rd axis (10th axis for just RT, instead of both LT and RT)
Get Motion from All Joysticks

https://stackoverflow.com/questions/28058454/xbox-one-right-trigger-not-working


