public class DeliveryRobot
{
    private INavigationState navigationState;
    private IPackageHandlingState packageHandlingState;

    public DeliveryRobot()
    {
        navigationState = new Moving();
        packageHandlingState = new Empty();
    }

    public void HandleInput(Input input)
    {
        navigationState.HandleInput(this, input);
        packageHandlingState.HandleInput(this, input);
    }

    public void SetNavigationState(INavigationState newState)
    {
        navigationState = newState;
        Console.WriteLine("Navigation State changed to: " + newState.GetType().Name);
    }

    public void SetPackageHandlingState(IPackageHandlingState newState)
    {
        packageHandlingState = newState;
        Console.WriteLine("Package Handling State changed to: " + newState.GetType().Name);
    }
}

public enum Input
{
    ObstacleDetected, LowBattery, PackageLoaded, AtDestination, PackageDelivered, ObstacleAvoided, RobotInCharger
    // Additional inputs as required
}