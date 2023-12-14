class Empty : IPackageHandlingState
{
    public void HandleInput(DeliveryRobot robot, Input input)
    {
        if (input == Input.PackageLoaded)
        {
            robot.SetPackageHandlingState(new Loaded());
        }
    }
}

class Loaded : IPackageHandlingState
{
    public void HandleInput(DeliveryRobot robot, Input input)
    {
        if (input == Input.AtDestination)
        {
            robot.SetPackageHandlingState(new Delivering());
        }
    }
}

class Delivering : IPackageHandlingState
{
    public void HandleInput(DeliveryRobot robot, Input input)
    {
        if (input == Input.PackageDelivered)
        {
            robot.SetPackageHandlingState(new Empty());
        }
    }
}
