class Program
{
    static void Main(string[] args)
    {
        DeliveryRobot robot = new DeliveryRobot();

        // Simulate inputs
        robot.HandleInput(Input.PackageLoaded);
        robot.HandleInput(Input.AtDestination);
        robot.HandleInput(Input.PackageDelivered);
        robot.HandleInput(Input.ObstacleDetected);
        robot.HandleInput(Input.ObstacleAvoided);
        robot.HandleInput(Input.LowBattery);
        robot.HandleInput(Input.RobotInCharger);

        // Add more simulation logic as needed
    }
}
