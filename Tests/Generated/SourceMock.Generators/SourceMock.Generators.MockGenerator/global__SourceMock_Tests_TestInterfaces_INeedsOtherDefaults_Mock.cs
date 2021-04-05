﻿#nullable enable
namespace SourceMock.Tests.TestInterfaces.Mocks {
    [SourceMock.Internal.GeneratedMock]
    public class MockINeedsOtherDefaults : global::SourceMock.Tests.TestInterfaces.INeedsOtherDefaults, ISetupINeedsOtherDefaults, ICallsINeedsOtherDefaults {
        public ISetupINeedsOtherDefaults Setup => this;
        public ICallsINeedsOtherDefaults Calls => this;

        private readonly SourceMock.Internal.MockMethodHandler<global::System.Threading.Tasks.Task> _executeAsync1Handler = new();
        SourceMock.IMockMethodSetup<global::System.Threading.Tasks.Task> ISetupINeedsOtherDefaults.ExecuteAsync() => _executeAsync1Handler.Setup();
        public global::System.Threading.Tasks.Task ExecuteAsync() => _executeAsync1Handler.Call();
        System.Collections.Generic.IReadOnlyList<SourceMock.NoArguments> ICallsINeedsOtherDefaults.ExecuteAsync() => _executeAsync1Handler.Calls(_ => SourceMock.NoArguments.Value);

        private readonly SourceMock.Internal.MockMethodHandler<global::System.Threading.Tasks.Task<object>> _getStringAsync2Handler = new();
        SourceMock.IMockMethodSetup<global::System.Threading.Tasks.Task<object>> ISetupINeedsOtherDefaults.GetStringAsync() => _getStringAsync2Handler.Setup();
        public global::System.Threading.Tasks.Task<object> GetStringAsync() => _getStringAsync2Handler.Call();
        System.Collections.Generic.IReadOnlyList<SourceMock.NoArguments> ICallsINeedsOtherDefaults.GetStringAsync() => _getStringAsync2Handler.Calls(_ => SourceMock.NoArguments.Value);

        private readonly SourceMock.Internal.MockMethodHandler<global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<int>>> _getListAsync3Handler = new();
        SourceMock.IMockMethodSetup<global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<int>>> ISetupINeedsOtherDefaults.GetListAsync() => _getListAsync3Handler.Setup();
        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<int>> GetListAsync() => _getListAsync3Handler.Call();
        System.Collections.Generic.IReadOnlyList<SourceMock.NoArguments> ICallsINeedsOtherDefaults.GetListAsync() => _getListAsync3Handler.Calls(_ => SourceMock.NoArguments.Value);
    }

    [SourceMock.Internal.GeneratedMock]
    public interface ISetupINeedsOtherDefaults {
        SourceMock.IMockMethodSetup<global::System.Threading.Tasks.Task> ExecuteAsync();
        SourceMock.IMockMethodSetup<global::System.Threading.Tasks.Task<object>> GetStringAsync();
        SourceMock.IMockMethodSetup<global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<int>>> GetListAsync();
    }

    [SourceMock.Internal.GeneratedMock]
    public interface ICallsINeedsOtherDefaults {
        System.Collections.Generic.IReadOnlyList<SourceMock.NoArguments> ExecuteAsync();
        System.Collections.Generic.IReadOnlyList<SourceMock.NoArguments> GetStringAsync();
        System.Collections.Generic.IReadOnlyList<SourceMock.NoArguments> GetListAsync();
    }

    [SourceMock.Internal.GeneratedMock]
    public static class global__SourceMock_Tests_TestInterfaces_INeedsOtherDefaults_Mock {
        public static MockINeedsOtherDefaults Get(this SourceMock.Mock<global::SourceMock.Tests.TestInterfaces.INeedsOtherDefaults> _) => new();
    }
}