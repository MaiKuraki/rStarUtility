#region

using System;
using System.Collections.Generic;
using Actor.ExposedActor.Interfaces;
using Actor.Scripts.Core.UseCase;
using DDDCore.Usecase.CQRS;
using ThirtyParty.DDDCore.Implement.CQRS;
using Utilities.Contract;
using Zenject;

#endregion

namespace Actor.Adapter.Controller
{
    public class ActorController
    {
    #region Private Variables

        [Inject]
        private CreateActorUseCase createActorUseCase;

        private readonly CreateActorInput     createActorInput;
        private readonly CqrsCommandPresenter createActorOutput;

        [Inject]
        private IActorRepository actorRepository;

    #endregion

    #region Constructor

        public ActorController()
        {
            createActorInput  = new CreateActorInput();
            createActorOutput = new CqrsCommandPresenter();
        }

    #endregion

    #region Public Methods

        public CqrsCommandPresenter CreateActor(string dataId)
        {
            createActorInput.Id     = Guid.NewGuid().ToString();
            createActorInput.DataId = dataId;
            createActorUseCase.Execute(createActorInput , createActorOutput);
            var exitCode = createActorOutput.GetExitCode();
            Contract.Ensure(exitCode != ExitCode.FAILURE , "ExitCode is FAILURE");
            return createActorOutput;
        }

        public List<IActorReadModel> GetAllActor()
        {
            return actorRepository.GetAll();
        }

    #endregion
    }
}