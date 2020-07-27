https://refactoring.guru/design-patterns/abstract-factory

Abstract Factory is a creational design pattern that lets you produce families of 
related objects without specifying their concrete classes.

The first thing the Abstract Factory pattern suggests is to explicitly declare interfaces 
for each distinct product of the product family (e.g., chair, sofa or coffee table). 
Then you can make all variants of products follow those interfaces.

The next move is to declare the Abstract Factory—an interface with a list of creation methods 
for all products that are part of the product family (for example, createChair, createSofa and createCoffeeTable). 
These methods must return abstract product types represented by the interfaces we 
extracted previously: Chair, Sofa, CoffeeTable and so on.

Now, how about the product variants? For each variant of a product family, we create a 
separate factory class based on the AbstractFactory interface. A factory is a class that 
returns products of a particular kind. For example, the ModernFurnitureFactory can only create 
ModernChair, ModernSofa and ModernCoffeeTable objects.

Say the client wants a factory to produce a chair. The client doesn’t have to be aware of the 
factory’s class, nor does it matter what kind of chair it gets. Whether it’s a Modern model or a 
Victorian-style chair, the client must treat all chairs in the same manner, using the abstract 
Chair interface. With this approach, the only thing that the client knows about the chair is 
that it implements the sitOn method in some way. Also, whichever variant of the chair is returned, 
it’ll always match the type of sofa or coffee table produced by the same factory object.

There’s one more thing left to clarify: if the client is only exposed to the abstract interfaces, 
what creates the actual factory objects? Usually, the application creates a concrete factory object 
at the initialization stage. Just before that, the app must select the factory type depending 
on the configuration or the environment settings.

How to Implement
1. Map out a matrix of distinct product types versus variants of these products.
2. Declare abstract product interfaces for all product types. Then make all concrete product classes implement these interfaces.
3. Declare the abstract factory interface with a set of creation methods for all abstract products.
4. Implement a set of concrete factory classes, one for each product variant.
5. Create factory initialization code somewhere in the app. It should instantiate one of the concrete factory classes, 
depending on the application configuration or the current environment. Pass this factory object to all classes that construct products.
6. Scan through the code and find all direct calls to product constructors. Replace them with calls to the appropriate creation method on the factory object.