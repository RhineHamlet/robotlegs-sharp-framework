//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
namespace robotlegs.bender.extensions.mediatorMap.dsl
{
	/// <summary>
	/// Maps a matcher to a concrete Mediator type
	/// </summary>
	public interface IMediatorMapper
	{
		/// <summary>
		/// Maps a matcher to a concrete Mediator type
		/// </summary>
		/// <returns>Mapping configurator</returns>
		/// <param name="mediatorType">The concrete mediator type</param>
		IMediatorConfigurator ToMediator(Type mediatorType);
		IMediatorConfigurator ToMediator<T>();

	}
}

