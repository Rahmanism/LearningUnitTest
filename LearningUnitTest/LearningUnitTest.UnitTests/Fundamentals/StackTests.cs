using System;
using LearningUnitTest.Fundamentals;
using NUnit.Framework;

namespace LearningUnitTest.UnitTests.Fundamentals
{
    [TestFixture]
    public class StackTests
    {
        private Stack<string> _stack;

        [SetUp]
        public void SetUp()
        {
            _stack = new Stack<string>();
        }

        [Test]
        public void Push_ArgIsNull_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => _stack.Push(null));
        }

        [Test]
        public void Push_ArgIsValid_AddTheObjToStack()
        {
            _stack.Push("a");
            
            Assert.That(_stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            Assert.That(_stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Pop_StackIsEmpty_ThrowInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => _stack.Pop());
        }

        [Test]
        public void Pop_StackWithObjects_ReturnTheObjOnTop()
        {
            _stack.Push("a");
            _stack.Push("b");
            _stack.Push("c");

            var result = _stack.Pop();
            
            Assert.That(result, Is.EqualTo("c"));
        }

        [Test]
        public void Pop_StackWithObjects_RemoveTheTopObject()
        {
            _stack.Push("a");
            _stack.Push("b");
            _stack.Push("c");

            _stack.Pop();
            
            Assert.That(_stack.Count, Is.EqualTo(2));
        }
     
        [Test]
        public void Peek_StackIsEmpty_ThrowInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => _stack.Pop());
        }

        [Test]
        public void Peek_StackWithObjects_ReturnTheObjOnTop()
        {
            _stack.Push("a");
            _stack.Push("b");
            _stack.Push("c");

            var result = _stack.Peek();
            
            Assert.That(result, Is.EqualTo("c"));
        }
        
        [Test]
        public void Peek_StackWithObjects_DoesNotRemoveTheTopObject()
        {
            _stack.Push("a");
            _stack.Push("b");
            _stack.Push("c");

            _stack.Peek();
            
            Assert.That(_stack.Count, Is.EqualTo(3));
        }
    }
}