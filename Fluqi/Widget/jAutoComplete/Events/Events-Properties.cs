﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jAutoComplete
{

	/// <summary>
	/// A set of events to apply to a set of jQuery UI AutoComplete.
	/// </summary>
	public partial class Events: Core.Options
	{
		/// <summary>
		/// Before a request (source-option) is started, after minLength and delay are met. 
		/// Can be canceled (return false), then no request will be started and no items suggested.
		/// </summary>
		protected internal string SearchEvent { get; set; }

		/// <summary>
		/// Triggered after a search completes, but before the menu is shown. Useful for local manipuation
		/// of suggestion data, where a custom "source" option callback is not required. This event is always
		/// triggered when a search completes, even if the menu will not be shown because there are no results or
		/// the Autocomplete is disabled.
		/// </summary>
		protected internal string ResponseEvent { get; set; }
		
		/// <summary>
		/// This event is triggered when autocomplete is created.
		/// </summary>
		protected internal string CreateEvent { get; set; }

		/// <summary>
		/// Triggered when the suggestion menu is opened.
		/// </summary>
		protected internal string OpenEvent { get; set; }

		/// <summary>
		/// Before focus is moved to an item (not selecting), ui.item refers to the focused item. 
		/// The default action of focus is to replace the text field's value with the value of the 
		/// focused item, though only if the focus event was triggered by a keyboard interaction. 
		/// Canceling this event prevents the value from being updated, but does not prevent 
		/// the menu item from being focused.
		/// </summary>
		protected internal string FocusEvent { get; set; }

		/// <summary>
		/// Triggered when an item is selected from the menu; ui.item refers to the selected item. 
		/// The default action of select is to replace the text field's value with the value of 
		/// the selected item. Canceling this event prevents the value from being updated, but 
		/// does not prevent the menu from closing.
		/// </summary>
		protected internal string SelectEvent { get; set; }
		
		/// <summary>
		/// When the list is hidden - doesn't have to occur together with a change.
		/// </summary>
		protected internal string CloseEvent { get; set; }

		/// <summary>
		/// Triggered when the field is blurred, if the value has changed; ui.item refers to the selected item.
		/// </summary>
		protected internal string ChangeEvent { get; set; }

	} // Events

} // ns Fluqi.jAutoComplete
