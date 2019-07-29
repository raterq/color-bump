using Entitas;

public class DestroyerComponent : IComponent{public IDestroyer value;}
public class DestroyedComponent : IComponent{}
public class DestroyAfterAnimationFinishedComponent : IComponent{}
public class DestroyAfterOutOfScreenComponent : IComponent{}