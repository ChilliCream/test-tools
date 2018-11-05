using System.Runtime.CompilerServices;
using Xunit;

namespace ChilliCream.Testing
{
    public static class ObjectExtensions
    {
        public static void Snapshot(
            this object obj,
            [CallerMemberName]string snapshotName = null)
        {
            Assert.Equal(HotChocolate.Snapshot.Current(snapshotName),
                HotChocolate.Snapshot.New(obj, snapshotName));
            HotChocolate.Snapshot.Clean(obj, snapshotName);
        }
    }
}
