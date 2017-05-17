using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace CocosSharpFormsSample.ViewModels
{
	public class MainPageViewModel : BindableBase
	{

		public GameScene GameScene { get; set; }

		public DelegateCommand TokyoCommand => new DelegateCommand(PlayAnimationTokyo);
		public DelegateCommand KanagawaCommand => new DelegateCommand(PlayAnimationKanagawa);
		public DelegateCommand SaitamaCommand => new DelegateCommand(PlayAnimationSaitama);
		public DelegateCommand ChibaCommand => new DelegateCommand(PlayAnimationChiba);
		public DelegateCommand GunmaCommand => new DelegateCommand(PlayAnimationGunma);
		public DelegateCommand TochigiCommand => new DelegateCommand(PlayAnimationTochigi);
		public DelegateCommand IbarakiCommand => new DelegateCommand(PlayAnimationIbaraki);

		private INavigationService navigationService;

		public MainPageViewModel(INavigationService navigationService)
		{
			this.navigationService = navigationService;
		}

		private void PlayAnimationTokyo()
		{
			GameScene.PlayAnimationTokyo();
		}

		private void PlayAnimationKanagawa()
		{
			GameScene.PlayAnimationKanagawa();
		}

		private void PlayAnimationSaitama()
		{
			GameScene.PlayAnimationSaitama();
		}

		private void PlayAnimationChiba()
		{
			GameScene.PlayAnimationChiba();
		}

		private void PlayAnimationGunma()
		{
			GameScene.PlayAnimationGunma();
		}

		private void PlayAnimationTochigi()
		{
			GameScene.PlayAnimationTochigi();
		}

		private void PlayAnimationIbaraki()
		{
			GameScene.PlayAnimationIbaraki();
		}

	}
}
