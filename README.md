# SharpenTheCSharp
An exercise project to study C#, .NET Core, NuGet, and WPF(or Avalonia), building an GUI desktop application program targeting Windows NT

## Environment:
* OS: Windows 10 (Windows NT), 64-bit
* Runtime(.NET): .NET SDK 7, .NET Core (not .NET Framework, exactly)
* IDE: ~~VS Code with C# extensions, JetBrains Rider (no Visual Studio); Rider will be major IDE for the project.(due to lack of the cooperative GUI designing function provided by VS Code and its extensions)~~
  * [REVISED] Visual Studio Community is also available; both Rider and Visual Studio Community will be major IDEs.
* GUI: ~~WPF~~ (*Avalonia* is also an available option)
  * [REVISED] at this moment, *Avalonia* is chosen and highly considered for UI/GUI programming.
* Dependencies: Out of scope at this moment -> (working in progress)
  * [GUI] *Avalonia* (IDE plug-in)
  * [GUI] *ScottPlot.Avalonia* (NuGet package)
  * [UI] *Avalonia.ReactiveUI* (? - in consideration)

### [GUI][InProgress] Avalonia UI
* 구현 단계/수준별로 코드를 작성하고 이후 주석 등으로 분리하려고 한다: 바로 code behind인 경우, 일종의 controller 형태로 적용되는 경우(?), (다르다고 봐야하는지 좀 애매하지만) Binding 적용되는 경우, 그리고 Avalonia식 MVVM이 적용되는 경우별로의 예제를 남겨두려고 한다. 사실상 방법별로 모두 구현하더라도 공존할 수 있는 것으로 보이기 때문에 이렇게 해보려고 한다. 점점 스케일을 키워간다는 느낌? 그리고 최종적으로 MVVM 패턴 방식에 이르면 Framework를 쓰는 걸 고려하고, 그런 의미에서 DataBase에 대해 다루기도 한다. 넓게 보면 CRUD 관련된 사항까지도 어느 정도 이어진것 같다.(적어도 언급은 했지만 단순히 (웹) 프레임워크의 가능성을 말하면서 그냥 으레 나온 얘기였을 뿐인지는 다시 확인해봐야 알 것 같다.)
* ... 아니 애초에 2번째 단계도 MVVM의 일환이었던거 같은데, 그럼 네 가지로 나뉘었을때 중간의 두번째와 세번째는 무엇이 기준이지? 오히려 첫번째 케이스가 두 가지로 나뉘는 쪽인가? MVVM 비적용시에 말임.
* [TroubleShooting] 처음부터 Avalonia MVVM 프로젝트로 생성하지 않아서 아래와 같은 파일들을 수작업으로 생성하거나 하는 과정을 거쳤음.(첫번째 UserControl인 TextEditorView 쪽도 마찬가지다) 아래에 나열된 순서대로 파일을 구성했다.
  * C:\Users\Seiryu\RiderProjects\SharpenTheCSharp\DemoApp\ViewModels\TextEditorViewModel.cs
  * C:\Users\Seiryu\RiderProjects\SharpenTheCSharp\DemoApp\ViewModels\ViewModelBase.cs
  * C:\Users\Seiryu\RiderProjects\SharpenTheCSharp\DemoApp\Views\TextEditorView.axaml.cs
  * C:\Users\Seiryu\RiderProjects\SharpenTheCSharp\DemoApp\Views\TextEditorView.axaml
  * C:\Users\Seiryu\RiderProjects\SharpenTheCSharp\DemoApp\ViewModels\MainWindowViewModel.cs
  * 거기다 root 디렉터리에 있던 MainWindow.axaml과 그 .cs파일을 "\Views" 아래로 리팩터링해서 이동시켰다.
  * 이 과정에서 using을 다시 선언하는 과정과 함께 App.axaml.cs의 내용 조정도 있었고,
  * MainWindow.axaml.cs에 있던 MainWindowViewModel class를 해당 cs파일과 병합했다.(이걸로 ViewModel을 View쪽 코드(라곤 해도 MainWindow라서 포괄적으로 다룰 수도 있는 거지만)에 임시로 만들어 쓰는 방법은 못 쓰게 되는거네)
  * C:\Users\Seiryu\RiderProjects\SharpenTheCSharp\DemoApp\ViewLocator.cs
  * 여러모로 엄청나게 꼬인것 같군... 템플릿 구성 요소 같은게 누락되면서 꽤나 골치 아프게 된 것 같다.
* ReactiveUI 예제 중 'View Activation'과 'Routing' 파트를 있는 그대로 따라해보면서 안내 문서의 신뢰성을 검토해봤고, 첫 예제는 마찬가지로 에러 투성이에, 두번째 예제도 마찬가지였다.
  (이를 위해 솔루션 내부에 'ReactiveUiDemo'라는 프로젝트를 추가했고, 생성 자체부터 Avalonia-MVVM template을 이용했다)
  'View Activation' 파트는 내용이 적어 무시하고, 그 다음인 'Routing' 파트를 작성 완료한 다음 디버깅을 수행하다가, 아래 문서에서 특정 내용을 파악한 다음에서야 첫 빌드를 성공할 수 있었고, 실행 또한 되었다.
    > https://github.com/AvaloniaUI/Documentation/issues/379
    * 이 문제와 관련하여, 안내 문서가 outdated 되었거나, 작성 단계에서 애초에 문제가 있지 않았나 하는 생각이 든다.
    * 또한, '\*.axaml' 확장자가 아닌 '\*.xaml' 확장자를 사용하고 있는 점도 문제점이며, 거기에 더해서 기본적으로 namespace를 동일하게 가지고 가는데,
    이는 View, ViewModel, Model를 담고 있는 하위 폴더와, app.axaml과 program.cs, 그리고 ViewLocator들을 포함하는 (솔루션 기준) 프로젝트 루트 디렉터리 사이에서의 계층 구조를 무시하고, 동일한 디렉터리 내에 파일을 두려고 했거나, 
    혹은 (namespace에 계층을 반영하는) 좀 더 적절한 convention을 무시하는 오류를 범하고 있다고 생각할 수밖에 없어보인다. 이로써 AvaloniaUI측에서 현재(26, Jun, 2023) 제공하고 있는 ReactiveUI에 대한 안내 문서는 신뢰성이 상당히 떨어진다는 점을 알려두고자 한다.
    * 'Routing' 예제에서 컴파일 오류가 생긴 부분은 'AppViewLocator.cs' 파일이었고, 에러 코드는 CS0425였다.


### [ScratchPad]
* GUI form scratch 
> string Title
string FilePath
string TextLiteral
string Encoding

> EDITOR PANEL
ROW1
SampleRadioButton:{sample, edit}
ROW2
TextTitle: Title name in DB or Real file name
ROW3
if SRB = sample:
TextFilePath: single line text
TextLoadButton: "Load"
TextSaveButton: "Save"
else:
SampleTextList(provided by db)
ROW4
TextBox
