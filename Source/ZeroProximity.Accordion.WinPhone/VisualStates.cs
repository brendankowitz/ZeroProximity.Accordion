﻿using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace ZeroProximity.Controls
{
    internal static class VisualStates
    {
        #region GroupCommon
        /// <summary>
        /// Common state group.
        /// </summary>
        public const string GroupCommon = "CommonStates";

        /// <summary>
        /// Normal state of the Common state group.
        /// </summary>
        public const string StateNormal = "Normal";

        /// <summary>
        /// Normal state of the Common state group.
        /// </summary>
        public const string StateReadOnly = "ReadOnly";

        /// <summary>
        /// MouseOver state of the Common state group.
        /// </summary>
        public const string StateMouseOver = "MouseOver";

        /// <summary>
        /// Pressed state of the Common state group.
        /// </summary>
        public const string StatePressed = "Pressed";

        /// <summary>
        /// Disabled state of the Common state group.
        /// </summary>
        public const string StateDisabled = "Disabled";
        #endregion GroupCommon

        #region GroupFocus
        /// <summary>
        /// Focus state group.
        /// </summary>
        public const string GroupFocus = "FocusStates";

        /// <summary>
        /// Unfocused state of the Focus state group.
        /// </summary>
        public const string StateUnfocused = "Unfocused";

        /// <summary>
        /// Focused state of the Focus state group.
        /// </summary>
        public const string StateFocused = "Focused";
        #endregion GroupFocus

        #region GroupSelection
        /// <summary>
        /// Selection state group.
        /// </summary>
        public const string GroupSelection = "SelectionStates";

        /// <summary>
        /// Selected state of the Selection state group.
        /// </summary>
        public const string StateSelected = "Selected";

        /// <summary>
        /// Unselected state of the Selection state group.
        /// </summary>
        public const string StateUnselected = "Unselected";

        /// <summary>
        /// Selected inactive state of the Selection state group.
        /// </summary>
        public const string StateSelectedInactive = "SelectedInactive";
        #endregion GroupSelection

        #region GroupExpansion
        /// <summary>
        /// Expansion state group.
        /// </summary>
        public const string GroupExpansion = "ExpansionStates";

        /// <summary>
        /// Expanded state of the Expansion state group.
        /// </summary>
        public const string StateExpanded = "Expanded";

        /// <summary>
        /// Collapsed state of the Expansion state group.
        /// </summary>
        public const string StateCollapsed = "Collapsed";
        #endregion GroupExpansion

        #region GroupPopup
        /// <summary>
        /// Popup state group.
        /// </summary>
        public const string GroupPopup = "PopupStates";

        /// <summary>
        /// Opened state of the Popup state group.
        /// </summary>
        public const string StatePopupOpened = "PopupOpened";

        /// <summary>
        /// Closed state of the Popup state group.
        /// </summary>
        public const string StatePopupClosed = "PopupClosed";
        #endregion

        #region GroupValidation
        /// <summary>
        /// ValidationStates state group.
        /// </summary>
        public const string GroupValidation = "ValidationStates";

        /// <summary>
        /// The valid state for the ValidationStates group.
        /// </summary>
        public const string StateValid = "Valid";

        /// <summary>
        /// Invalid, focused state for the ValidationStates group.
        /// </summary>
        public const string StateInvalidFocused = "InvalidFocused";

        /// <summary>
        /// Invalid, unfocused state for the ValidationStates group.
        /// </summary>
        public const string StateInvalidUnfocused = "InvalidUnfocused";
        #endregion

        #region GroupExpandDirection
        /// <summary>
        /// ExpandDirection state group.
        /// </summary>
        public const string GroupExpandDirection = "ExpandDirectionStates";

        /// <summary>
        /// Down expand direction state of ExpandDirection state group.
        /// </summary>
        public const string StateExpandDown = "ExpandDown";

        /// <summary>
        /// Up expand direction state of ExpandDirection state group.
        /// </summary>
        public const string StateExpandUp = "ExpandUp";

        /// <summary>
        /// Left expand direction state of ExpandDirection state group.
        /// </summary>
        public const string StateExpandLeft = "ExpandLeft";

        /// <summary>
        /// Right expand direction state of ExpandDirection state group.
        /// </summary>
        public const string StateExpandRight = "ExpandRight";
        #endregion

        #region GroupHasItems
        /// <summary>
        /// HasItems state group.
        /// </summary>
        public const string GroupHasItems = "HasItemsStates";

        /// <summary>
        /// HasItems state of the HasItems state group.
        /// </summary>
        public const string StateHasItems = "HasItems";

        /// <summary>
        /// NoItems state of the HasItems state group.
        /// </summary>
        public const string StateNoItems = "NoItems";
        #endregion GroupHasItems

        #region GroupIncrease
        /// <summary>
        /// Increment state group.
        /// </summary>
        public const string GroupIncrease = "IncreaseStates";

        /// <summary>
        /// State enabled for increment group.
        /// </summary>
        public const string StateIncreaseEnabled = "IncreaseEnabled";

        /// <summary>
        /// State disabled for increment group.
        /// </summary>
        public const string StateIncreaseDisabled = "IncreaseDisabled";
        #endregion GroupIncrease

        #region GroupDecrease
        /// <summary>
        /// Decrement state group.
        /// </summary>
        public const string GroupDecrease = "DecreaseStates";

        /// <summary>
        /// State enabled for decrement group.
        /// </summary>
        public const string StateDecreaseEnabled = "DecreaseEnabled";

        /// <summary>
        /// State disabled for decrement group.
        /// </summary>
        public const string StateDecreaseDisabled = "DecreaseDisabled";
        #endregion GroupDecrease

        #region GroupIteractionMode
        /// <summary>
        /// InteractionMode state group.
        /// </summary>
        public const string GroupInteractionMode = "InteractionModeStates";

        /// <summary>
        /// Edit of the DisplayMode state group.
        /// </summary>
        public const string StateEdit = "Edit";

        /// <summary>
        /// Display of the DisplayMode state group.
        /// </summary>
        public const string StateDisplay = "Display";
        #endregion GroupIteractionMode

        #region GroupLocked
        /// <summary>
        /// DisplayMode state group.
        /// </summary>
        public const string GroupLocked = "LockedStates";

        /// <summary>
        /// Edit of the DisplayMode state group.
        /// </summary>
        public const string StateLocked = "Locked";

        /// <summary>
        /// Display of the DisplayMode state group.
        /// </summary>
        public const string StateUnlocked = "Unlocked";
        #endregion GroupLocked

        #region GroupActive
        /// <summary>
        /// Active state.
        /// </summary>
        public const string StateActive = "Active";

        /// <summary>
        /// Inactive state.
        /// </summary>
        public const string StateInactive = "Inactive";

        /// <summary>
        /// Active state group.
        /// </summary>
        public const string GroupActive = "ActiveStates";
        #endregion GroupActive

        #region GroupWatermark
        /// <summary>
        /// Non-watermarked state.
        /// </summary>
        public const string StateUnwatermarked = "Unwatermarked";

        /// <summary>
        /// Watermarked state.
        /// </summary>
        public const string StateWatermarked = "Watermarked";

        /// <summary>
        /// Watermark state group.
        /// </summary>
        public const string GroupWatermark = "WatermarkStates";
        #endregion GroupWatermark

        #region GroupCalendarButtonFocus
        /// <summary>
        /// Unfocused state for Calendar Buttons.
        /// </summary>
        public const string StateCalendarButtonUnfocused = "CalendarButtonUnfocused";

        /// <summary>
        /// Focused state for Calendar Buttons.
        /// </summary>
        public const string StateCalendarButtonFocused = "CalendarButtonFocused";

        /// <summary>
        /// CalendarButtons Focus state group.
        /// </summary>
        public const string GroupCalendarButtonFocus = "CalendarButtonFocusStates";
        #endregion GroupCalendarButtonFocus

        #region GroupBusyStatus
        /// <summary>
        /// Busy state for BusyIndicator.
        /// </summary>
        public const string StateBusy = "Busy";

        /// <summary>
        /// Idle state for BusyIndicator.
        /// </summary>
        public const string StateIdle = "Idle";

        /// <summary>
        /// Busyness group name.
        /// </summary>
        public const string GroupBusyStatus = "BusyStatusStates";
        #endregion

        #region GroupVisibility
        /// <summary>
        /// Visible state name for BusyIndicator.
        /// </summary>
        public const string StateVisible = "Visible";

        /// <summary>
        /// Hidden state name for BusyIndicator.
        /// </summary>
        public const string StateHidden = "Hidden";

        /// <summary>
        /// BusyDisplay group.
        /// </summary>
        public const string GroupVisibility = "VisibilityStates";
        #endregion

        public static void GoToState(Control control, bool useTransitions, params string[] stateNames)
        {
            Debug.Assert(control != null, "control should not be null!");
            Debug.Assert(stateNames != null, "stateNames should not be null!");
            Debug.Assert(stateNames.Length > 0, "stateNames should not be empty!");

            foreach (string name in stateNames)
            {
                if (VisualStateManager.GoToState(control, name, useTransitions))
                {
                    break;
                }
            }
        }
    }
}