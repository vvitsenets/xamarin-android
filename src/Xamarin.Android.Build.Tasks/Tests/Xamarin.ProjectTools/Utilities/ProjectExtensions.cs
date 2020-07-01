using System.Collections.Generic;

namespace Xamarin.ProjectTools
{
	public static class ProjectExtensions
	{
		public static void SetRuntimeIdentifier (this IShortFormProject project, string androidAbi)
		{
			if (androidAbi == "armeabi-v7a") {
				project.SetProperty (KnownProperties.RuntimeIdentifier, "android.21-arm");
			} else if (androidAbi == "arm64-v8a") {
				project.SetProperty (KnownProperties.RuntimeIdentifier, "android.21-arm64");
			} else if (androidAbi == "x86") {
				project.SetProperty (KnownProperties.RuntimeIdentifier, "android.21-x86");
			} else if (androidAbi == "x86_64") {
				project.SetProperty (KnownProperties.RuntimeIdentifier, "android.21-x64");
			}
		}

		public static void SetRuntimeIdentifiers (this IShortFormProject project, string [] androidAbis)
		{
			var abis = new List<string> ();
			foreach (var androidAbi in androidAbis) {
				if (androidAbi == "armeabi-v7a") {
					abis.Add ("android.21-arm");
				} else if (androidAbi == "arm64-v8a") {
					abis.Add ("android.21-arm64");
				} else if (androidAbi == "x86") {
					abis.Add ("android.21-x86");
				} else if (androidAbi == "x86_64") {
					abis.Add ("android.21-x64");
				}
			}
			project.SetProperty (KnownProperties.RuntimeIdentifiers, string.Join (";", abis));
		}
	}
}