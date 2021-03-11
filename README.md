# This repo is for creating code to teach principals of various languages in a way that is unambiguous and instructive

## Below is the console result from the first "test" case made. Future improvements are very likely.

The parameterized constructor will write the passed values to the console when called.
var class0 = new ClassToBeInitialized();
FirstInt=0 SecondInt=0 thirdInt=0 AString= BString= cString=

var class1 = new ClassToBeInitialized()
{
        FirstInt = 1,
        SecondInt = 2,
        AString = 'A',
        BString = 'B'
};

FirstInt=1 SecondInt=2 thirdInt=0 AString=A BString=B cString=

var class2 = new ClassToBeInitialized(10, 'a')
{
        SecondInt = 20,
        BString = 'b'
};

Set FirstInt to 10 and AString to a by constructor
FirstInt=10 SecondInt=20 thirdInt=0 AString=a BString=b cString=

var class3 = new ClassToBeInitialized(a: 'A0', first: 100)
{
        SecondInt = 200,
        BString = 'B0'
};

Set FirstInt to 100 and AString to A0 by constructor
FirstInt=100 SecondInt=200 thirdInt=0 AString=A0 BString=B0 cString=

var class4 = new ClassToBeInitialized(a: 'A0', first: 100)
{
        FirstInt = 1000,
        SecondInt = 2000,
        AString = 'A1',
        BString = 'B2'
};

Set FirstInt to 100 and AString to A0 by constructor
FirstInt=1000 SecondInt=2000 thirdInt=0 AString=A1 BString=B2 cString=
