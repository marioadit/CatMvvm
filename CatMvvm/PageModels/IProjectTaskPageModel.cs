using CatMvvm.Models;
using CommunityToolkit.Mvvm.Input;

namespace CatMvvm.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}