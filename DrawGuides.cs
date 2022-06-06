namespace PositionalGuide;

using System;

[Flags]
public enum DrawGuides: ushort {
	None = 0,
	Front = 1,
	Right = 2,
	Back = 4,
	Left = 8,
	FrontRight = 16,
	BackRight = 32,
	BackLeft = 64,
	FrontLeft = 128,

	Cardinals = Front | Right | Back | Left,
	Diagonals = FrontLeft | FrontRight | BackRight | BackLeft,
	All = Cardinals | Diagonals,
}
