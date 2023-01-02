namespace TreehouseDefense{
  class ShieldedInvader : Invader {

    public override int Health { get; protected set; }=2;

    public ShieldedInvader(Path path) : base(path)
    {
    }
    // Polymorphic
        public override void DecreaseHealth(int factor)
        {
          if(Random.NextDouble() < .5){
            base.DecreaseHealth(factor);
          }
        }
  }
}