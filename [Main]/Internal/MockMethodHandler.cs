using System;
using System.Collections.Generic;
using System.Linq;

namespace SourceMock.Internal {
    public class MockMethodHandler<TReturn> {
        private readonly IList<IMockMethodSetupInternal> _setups = new List<IMockMethodSetupInternal>();
        private readonly IList<object?[]> _calls = new List<object?[]>();

        public IMockMethodSetup<TReturn> Setup(params IMockArgumentMatcher[] arguments) {
            var setup = new MockMethodSetup<TReturn>(arguments);
            _setups.Add(setup);
            return setup;
        }

        public TReturn Call(params object?[] arguments) {
            _calls.Add(arguments);

            var setup = _setups.FirstOrDefault(s => ArgumentsMatch(arguments, s.Arguments));
            if (setup == null || !setup.HasReturnValue)
                return default!;

            return (TReturn)setup.ReturnValue!;
        }

        public IReadOnlyList<T> Calls<T>(Func<object?[], T> convertResult, params IMockArgumentMatcher[] arguments) {
            return _calls
                .Where(c => ArgumentsMatch(c, arguments))
                .Select(convertResult)
                .Cast<T>()
                .ToList();
        }

        private bool ArgumentsMatch(object?[] arguments, IReadOnlyList<IMockArgumentMatcher> matchers) {
            return arguments.Zip(matchers, (a, m) => m.Matches(a)).All(m => m);
        }
    }
}