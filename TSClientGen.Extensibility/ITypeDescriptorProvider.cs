using System;
using System.Reflection;
using TSClientGen.Extensibility.ApiDescriptors;

namespace TSClientGen.Extensibility
{
	/// <summary>
	/// Extensibility point for providing custom mappings of .net types to TypeScript types.
	/// This is for altering complex interface definition such as altering the set of interface members.
	/// </summary>
	public interface ITypeDescriptorProvider
	{
		/// <summary>
		/// Takes an interface descriptor generated by the api discovery
		/// and returns a modified descriptor to use for code generation.
		/// </summary>
		/// <param name="modelType">source .net type</param>
		/// <param name="descriptor">original type descriptor constructed by the TSClientGet</param>
		/// <param name="getPropertyInfo">
		/// allows for getting PropertyInfo for specified type property descriptor
		/// (in case you want to check some attributes applied to property for instance)
		/// </param>
		TypeDescriptor DescribeType(
			Type modelType,
			TypeDescriptor descriptor,
			Func<TypePropertyDescriptor, PropertyInfo> getPropertyInfo);		
	}
}