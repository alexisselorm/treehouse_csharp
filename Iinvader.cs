namespace TreehouseDefense;

interface IInvader{
      MapLocation Location{get;}

    // Create a health property for the invader. Its getter is public so that users may see its health. but the setter is private. If other classes want to change the value or health, they can use the 'DecreaseHealth' method
     int Health { get; }

    // If invader has reached the end of the path
     bool HasScored {get;}
// Return true if invaders Health is less than or equal to 0
     bool IsNeutralized{get;}

     bool IsActive {get;}

      void Move();

      void DecreaseHealth(int factor);
    
  }
