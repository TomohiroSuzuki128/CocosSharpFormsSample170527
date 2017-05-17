using System;

using CocosSharp;

namespace CocosSharpFormsSample
{
	public class GameScene : CCScene
	{
		GameLayer layer;

		public GameScene(CCGameView gameView) : base(gameView)
		{
			layer = new GameLayer(CCColor4B.Black);
			AddLayer(layer);
		}

		public void PlayAnimationTokyo()
		{
			layer.PlayAnimationTokyo();
		}

		public void PlayAnimationKanagawa()
		{
			layer.PlayAnimationKanagawa();
		}

		public void PlayAnimationSaitama()
		{
			layer.PlayAnimationSaitama();
		}

		public void PlayAnimationChiba()
		{
			layer.PlayAnimationChiba();
		}

		public void PlayAnimationGunma()
		{
			layer.PlayAnimationGunma();
		}

		public void PlayAnimationTochigi()
		{
			layer.PlayAnimationTochigi();
		}

		public void PlayAnimationIbaraki()
		{
			layer.PlayAnimationIbaraki();
		}

	}
}