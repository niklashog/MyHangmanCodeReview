using Autofac;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HangmanCodeReview.Interfaces;

namespace HangmanCodeReview.Factories
{
    public class FactoryOne
    {
        public static IContainer _container;
        public static void BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Game>().As<IGame>();
            builder.RegisterType<Lives>().As<ILives>();
            builder.RegisterType<WelcomeMessage>().As<IWelcomeMessage>();
            builder.RegisterType<WordGenerator>().As<IWordGenerator>();
            builder.RegisterType<HangmanVisual>().As<IHangmanVisual>();
            builder.RegisterType<GameOverScreen>().As<IGameOverScreen>();
            builder.RegisterType<WrongGuessPrompt>().As<IWrongGuessPrompt>();
            builder.RegisterType<DuplicateGuess>().As<IDuplicateGuess>();

            _container = builder.Build();
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
