Credit: https://refactoring.guru/design-patterns/adapter

**Adapter** is a structural design pattern that allows objects with incompatible interfaces to collaborate.

You can create an adapter. This is a special object that converts the interface of one object so that another object can understand it.

An adapter wraps one of the objects to hide the complexity of conversion happening behind the scenes. 
The wrapped object isn’t even aware of the adapter. For example, you can wrap an object that operates in 
meters and kilometers with an adapter that converts all of the data to imperial units such as feet and miles.

**How to Implement**
1. Make sure that you have at least two classes with incompatible interfaces:
	A useful service class, which you can’t change (often 3rd-party, legacy or with lots of existing dependencies).
	One or several client classes that would benefit from using the service class.
2. Declare the client interface and describe how clients communicate with the service.
3. Create the adapter class and make it follow the client interface. Leave all the methods empty for now.
4. Add a field to the adapter class to store a reference to the service object. The common practice is to 
initialize this field via the constructor, but sometimes it’s more convenient to pass it to the adapter when calling its methods.
5. One by one, implement all methods of the client interface in the adapter class. The adapter should 
delegate most of the real work to the service object, handling only the interface or data format conversion.
6. Clients should use the adapter via the client interface. This will let you change or extend the adapters without affecting the client code.