﻿/*
 * Copyright (c) 2019 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using SafeExamBrowser.Contracts.UserInterface.Browser.Events;

namespace SafeExamBrowser.Contracts.UserInterface.Browser
{
	/// <summary>
	/// Defines the functionality of a browser control (i.e. an instance of the browser resp. its user interface) and is normally embedded
	/// within an <see cref="IBrowserWindow"/>.
	/// </summary>
	public interface IBrowserControl
	{
		/// <summary>
		/// Event fired when the address of the browser control changes.
		/// </summary>
		event AddressChangedEventHandler AddressChanged;

		/// <summary>
		/// Event fired when the loading state of the browser control changes.
		/// </summary>
		event LoadingStateChangedEventHandler LoadingStateChanged;

		/// <summary>
		/// Event fired when the current page (and thus the title) of the browser control changes.
		/// </summary>
		event TitleChangedEventHandler TitleChanged;

		/// <summary>
		/// Initializes the browser control.
		/// </summary>
		void Initialize();

		/// <summary>
		/// Navigates to the previous page in the browser control history.
		/// </summary>
		void NavigateBackwards();

		/// <summary>
		/// Navigates to the next page in the browser control history.
		/// </summary>
		void NavigateForwards();

		/// <summary>
		/// Navigates to the specified web address.
		/// </summary>
		void NavigateTo(string address);

		/// <summary>
		/// Reloads the current web page.
		/// </summary>
		void Reload();
	}
}
