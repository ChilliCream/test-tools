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
            Assert.Equal(Testing.Snapshot.Current(snapshotName),
                Testing.Snapshot.New(obj, snapshotName));
            Testing.Snapshot.Clean(obj, snapshotName);
        }
    }
}
