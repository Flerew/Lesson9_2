using System;
using UnityEngine;
using Zenject;

public class MediatorInstaller : MonoInstaller
{
    [SerializeField] private GameplayMediator _gameplayMediator;

    public override void InstallBindings()
    {
        Container.Bind<Level>().AsSingle();
        BindInstance();
    }

    private void BindInstance()
    {
        GameplayMediator mediator = Container.InstantiatePrefabForComponent<GameplayMediator>(_gameplayMediator);
        Container.BindInterfacesAndSelfTo<GameplayMediator>().FromInstance(_gameplayMediator).AsSingle();
    }
}
