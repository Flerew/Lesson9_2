using Zenject;

public class GlobalInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<Level>().AsSingle();
        Container.Bind<GameplayMediator>().AsSingle();
    }
}
