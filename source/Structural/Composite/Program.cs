var root = new Composite("Root");

root.Add(new Leaf("Leaf A"));

root.Add(new Leaf("Leaf B"));

root.Add(new Leaf("Leaf C"));

var branch = new Composite("Branch");

branch.Add(new Leaf("Leaf D"));

branch.Add(new Leaf("Leaf E"));

root.Add(branch);

root.Show(0);

Console.ReadKey();
