Feature: Real Proxy

@UnitTest
Scenario: RealProxy - UT-01 - Should return a value when calling a function through the object real proxy
	Given a proxied function with a return value
	When the proxied function with a return value is called
	Then the value returned from the proxied function with a return value has the correct return value
	
@UnitTest
Scenario: RealProxy - UT-02 - Should allow usage of ref parameters when calling a method through the object real proxy
	Given a proxied method with ref parameters
	When the proxied method with ref parameters is called
	Then the ref parameters from the proxied method have the correct values

@UnitTest
Scenario: RealProxy - UT-03 - Should allow usage of in, out and ref parameters when calling a function through the object real proxy
	Given a proxied function with in, out and ref parameters
	When the proxied function with in, out and ref parameters is called
	Then the return value, out and ref parameters from the proxied function have the correct values
