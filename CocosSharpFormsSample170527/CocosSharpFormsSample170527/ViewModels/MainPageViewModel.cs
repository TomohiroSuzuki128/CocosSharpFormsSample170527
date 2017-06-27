using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace CocosSharpFormsSample.ViewModels
{
	public class MainPageViewModel : BindableBase
	{

		public GameScene GameScene { get; set; }

		public DelegateCommand TokyoCommand => new DelegateCommand(() => GameScene.PlayAnimationTokyo());
		public DelegateCommand KanagawaCommand => new DelegateCommand(() => GameScene.PlayAnimationKanagawa());
		public DelegateCommand SaitamaCommand => new DelegateCommand(() => GameScene.PlayAnimationSaitama());
		public DelegateCommand ChibaCommand => new DelegateCommand(() => GameScene.PlayAnimationChiba());
		public DelegateCommand GunmaCommand => new DelegateCommand(() => GameScene.PlayAnimationGunma());
		public DelegateCommand TochigiCommand => new DelegateCommand(() => GameScene.PlayAnimationTochigi());
		public DelegateCommand IbarakiCommand => new DelegateCommand(() => GameScene.PlayAnimationIbaraki());

		private INavigationService navigationService;

		public MainPageViewModel(INavigationService navigationService)
		{
			this.navigationService = navigationService;
		}

	}
}
