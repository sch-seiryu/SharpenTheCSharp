// {demo}{ReactiveUI} Created by as the reference below @230620-2101
// reference: "https://docs.avaloniaui.net/guides/deep-dives/reactiveui/routing"

using System;
using DemoApp.ViewModels;
using DemoApp.Views;
using ReactiveUI;

namespace DemoApp
{
    public class AppViewLocator : IViewLocator
    {
        // public IViewFor ResolveView<T>(T viewModel, string contract = null) where T : class => viewModel switch
        // {demo}{buildError}:
        //  AppViewLocator.cs(14, 25): [CS0425] 'AppViewLocator.ResolveView<T>(T, string)' 메서드의 'T' 형식 매개 변수에 대한 제약 조건이 'IViewLocator.ResolveView<T>(T, string?)' 인터페이스 메서드의 'T' 형식 매개 변수에 대한 제약 조건과 일치해야 합니다. 명시적 인터페이스 구현을 대신 사용하세요.
        public IViewFor ResolveView<T>(T viewModel, string contract = null) => viewModel switch
        {
            FirstPageViewModel context => new FirstPageView { DataContext = context },
            _ => throw new ArgumentOutOfRangeException(nameof(viewModel))
        };
    }   
}