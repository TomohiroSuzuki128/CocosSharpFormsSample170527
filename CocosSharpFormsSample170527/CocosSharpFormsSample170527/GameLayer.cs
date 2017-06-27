using System;
using System.Diagnostics;

using CocosSharp;

namespace CocosSharpFormsSample
{
	public class GameLayer : CCLayerColor
	{
		private CCTexture2D tokyoTexture;
		private CCTexture2D kanagawaTexture;
		private CCTexture2D saitamaTexture;
		private CCTexture2D chibaTexture;
		private CCTexture2D gunmaTexture;
		private CCTexture2D tochigiTexture;
		private CCTexture2D ibarakiTexture;

		private CCSprite tokyoSprite;
		private CCSprite kanagawaSprite;
		private CCSprite saitamaSprite;
		private CCSprite chibaSprite;
		private CCSprite gunmaSprite;
		private CCSprite tochigiSprite;
		private CCSprite ibarakiSprite;

		private CCActionState tokyoActionState;
		private CCActionState kanagawaActionState;
		private CCActionState saitamaActionState;
		private CCActionState chibaActionState;
		private CCActionState gunmaActionState;
		private CCActionState tochigiActionState;
		private CCActionState ibarakiActionState;

		private CCBlink blink;
		private CCScaleBy scaleLarge;
		private CCEaseBackIn easedScaleLarge;
		private CCRotateBy rotate;
		private CCEaseBounceIn easedRotate;
		private CCScaleBy scaleOrigin;

		public GameLayer(CCColor4B? color = default(CCColor4B?)) : base(color)
		{
			tokyoTexture = new CCSprite("tokyo.png", null).Texture;
			kanagawaTexture = new CCSprite("kanagawa.png", null).Texture;
			saitamaTexture = new CCSprite("saitama.png", null).Texture;
			chibaTexture = new CCSprite("chiba.png", null).Texture;
			gunmaTexture = new CCSprite("gunma.png", null).Texture;
			tochigiTexture = new CCSprite("tochigi.png", null).Texture;
			ibarakiTexture = new CCSprite("ibaraki.png", null).Texture;

			var offsetX = 50f;

			tokyoSprite = new CCSprite(tokyoTexture)
			{
				PositionX = 96.25f + offsetX,
				PositionY = 126.25f,
				Scale = 0.3f,
				Tag = (int)Prefecture.Tokyo,
			};
			AddChild(tokyoSprite);

			kanagawaSprite = new CCSprite(kanagawaTexture)
			{
				PositionX = 90f + offsetX,
				PositionY = 93f,
				Scale = 0.3f,
				Tag = (int)Prefecture.Kanagawa,
			};
			AddChild(kanagawaSprite);

			saitamaSprite = new CCSprite(saitamaTexture)
			{
				PositionX = 84.5f + offsetX,
				PositionY = 163f,
				Scale = 0.3f,
				Tag = (int)Prefecture.Saitama,
			};
			AddChild(saitamaSprite);

			chibaSprite = new CCSprite(chibaTexture)
			{
				PositionX = 177.5f + offsetX,
				PositionY = 104f,
				Scale = 0.3f,
				Tag = (int)Prefecture.Chiba,
			};
			AddChild(chibaSprite);

			gunmaSprite = new CCSprite(gunmaTexture)
			{
				PositionX = 60f + offsetX,
				PositionY = 220f,
				Scale = 0.3f,
				Tag = (int)Prefecture.Gunma,
			};
			AddChild(gunmaSprite);

			tochigiSprite = new CCSprite(tochigiTexture)
			{
				PositionX = 131f + offsetX,
				PositionY = 238f,
				Scale = 0.3f,
				Tag = (int)Prefecture.Tochigi,
			};
			AddChild(tochigiSprite);

			ibarakiSprite = new CCSprite(ibarakiTexture)
			{
				PositionX = 174.5f + offsetX,
				PositionY = 200f,
				Scale = 0.3f,
				Tag = (int)Prefecture.Ibaraki,
			};
			AddChild(ibarakiSprite);

			blink = new CCBlink(2, 10);
			scaleLarge = new CCScaleBy(1, 4);
			easedScaleLarge = new CCEaseBackIn(scaleLarge);
			rotate = new CCRotateBy(3, 2880);
			easedRotate = new CCEaseBounceIn(rotate);
			scaleOrigin = new CCScaleBy(1, 0.25f);

		}

		public bool CanPlayAnimationTokyo
		{
			get { return tokyoActionState == null ? true : tokyoActionState.IsDone; }
		}

		public void PlayAnimationTokyo()
		{
			if (!CanPlayAnimationTokyo)
				return;

			var sequence = new CCSequence(
				new CCCallFunc(() => tokyoSprite.ZOrder = 1000),
				blink,
				easedScaleLarge,
				easedRotate,
				scaleOrigin,
				new CCCallFunc(() => tokyoSprite.ZOrder = 0)
				);
			tokyoActionState = tokyoSprite.RunAction(sequence);
		}

		public bool CanPlayAnimationKanagawa
		{
			get { return kanagawaActionState == null ? true : kanagawaActionState.IsDone; }
		}

		public void PlayAnimationKanagawa()
		{
			if (!CanPlayAnimationKanagawa)
				return;

			var sequence = new CCSequence(
				new CCCallFunc(() => kanagawaSprite.ZOrder = 1000),
				blink,
				easedScaleLarge,
				scaleOrigin,
				new CCCallFunc(() => kanagawaSprite.ZOrder = 0)
				);
			kanagawaActionState = kanagawaSprite.RunAction(sequence);
		}

		public bool CanPlayAnimationSaitama
		{
			get { return saitamaActionState == null ? true : saitamaActionState.IsDone; }
		}

		public void PlayAnimationSaitama()
		{
			if (!CanPlayAnimationSaitama)
				return;

			var sequence = new CCSequence(
				new CCCallFunc(() => saitamaSprite.ZOrder = 1000),
				blink,
				scaleLarge,
				rotate,
				scaleOrigin,
				new CCCallFunc(() => saitamaSprite.ZOrder = 0)
				);
			saitamaActionState = saitamaSprite.RunAction(sequence);
		}

		public bool CanPlayAnimationChiba
		{
			get { return chibaActionState == null ? true : chibaActionState.IsDone; }
		}

		public void PlayAnimationChiba()
		{
			if (!CanPlayAnimationChiba)
				return;

			var sequence = new CCSequence(
				new CCCallFunc(() => chibaSprite.ZOrder = 1000),
				easedScaleLarge,
				scaleOrigin,
				new CCCallFunc(() => chibaSprite.ZOrder = 0)
				);
			chibaActionState = chibaSprite.RunAction(sequence);
		}

		public bool CanPlayAnimationGunma
		{
			get { return gunmaActionState == null ? true : gunmaActionState.IsDone; }
		}

		public void PlayAnimationGunma()
		{
			if (!CanPlayAnimationGunma)
				return;

			var sequence = new CCSequence(blink);
			gunmaActionState = gunmaSprite.RunAction(sequence);
		}

		public bool CanPlayAnimationTochigi
		{
			get { return tochigiActionState == null ? true : tochigiActionState.IsDone; }
		}

		public void PlayAnimationTochigi()
		{
			if (!CanPlayAnimationTochigi)
				return;

			var sequence = new CCSequence(
				new CCCallFunc(() => tochigiSprite.ZOrder = 1000),
				scaleLarge,
				scaleOrigin,
				new CCCallFunc(() => tochigiSprite.ZOrder = 0),
				);
			tochigiActionState = tochigiSprite.RunAction(sequence);
		}

		public bool CanPlayAnimationIbaraki
		{
			get { return ibarakiActionState == null ? true : ibarakiActionState.IsDone; }
		}

		public void PlayAnimationIbaraki()
		{
			if (!CanPlayAnimationIbaraki)
				return;

			var sequence = new CCSequence(
				new CCCallFunc(() => ibarakiSprite.ZOrder = 1000),
				rotate,
				new CCCallFunc(() => ibarakiSprite.ZOrder = 0),
				);
			ibarakiActionState = ibarakiSprite.RunAction(sequence);
		}

	}

	public enum Prefecture
	{
		Tokyo,
		Kanagawa,
		Saitama,
		Chiba,
		Gunma,
		Tochigi,
		Ibaraki
	}

}