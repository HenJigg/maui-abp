namespace AppFramework.Behaviors
{
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}