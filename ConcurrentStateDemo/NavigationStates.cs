class Moving : INavigationState
{
  public void HandleInput(DeliveryRobot robot, Input input)
  {
    switch (input)
    {
      case Input.ObstacleDetected:
        robot.SetNavigationState(new AvoidingObstacles());
        break;
      case Input.LowBattery:
        Console.WriteLine("Battery is low. Returning to charging station.");
        robot.SetNavigationState(new Charging());
        break;
      default:
        // Continue moving logic
        Console.WriteLine("Robot is moving to the destination.");
        break;
    }
  }
}

class AvoidingObstacles : INavigationState
{
  public void HandleInput(DeliveryRobot robot, Input input)
  {
    // Example obstacle avoidance logic
    Console.WriteLine("Avoiding obstacles...");

    // After avoiding obstacles, robot returns to moving state
    robot.SetNavigationState(new Moving());
  }
}


class Charging : INavigationState
{
  private void StartCharging(DeliveryRobot robot)
  {
    Console.WriteLine("Charging...");
    bool isCharged = true;
    if (isCharged)
    {
      robot.SetNavigationState(new Moving());
    }
  }

  public void HandleInput(DeliveryRobot robot, Input input)
  {
    StartCharging(robot);
  }
}

