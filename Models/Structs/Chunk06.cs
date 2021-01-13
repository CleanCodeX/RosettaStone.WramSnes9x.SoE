using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using RosettaStone.Savestate.Snes9x.SoE.Constants;

namespace RosettaStone.Savestate.Snes9x.SoE.Models.Structs
{
	[DebuggerDisplay("ToString(),nq")]
	public struct Chunk06
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = WramSizes.SaveSlot.Chunk06)]
		public byte[] Data;

		public char[] AsChars => Encoding.ASCII.GetChars(Data);
		public string AsString => new(AsChars);
		public uint AsNumber => BitConverter.ToUInt32(Data);
		public uint AsNumberReversed => BitConverter.ToUInt32(Data.Reverse().ToArray());

		public override string ToString() => AsString;
	}
}