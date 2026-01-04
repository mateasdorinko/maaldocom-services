using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Tests.Unit.Api")]

namespace MaaldoCom.Services.Api;

public static class AssemblyReference
{
    public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
}