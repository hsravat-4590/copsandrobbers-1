/* 
 *  Copyright (C) 2021 Deranged Senators
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *  
 *      http:www.apache.org/licenses/LICENSE-2.0
 *  
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;
using Me.DerangedSenators.CopsAndRobbers;
using UnityEngine.UI;

namespace Me.DerangedSenators.CopsAndRobbers
{

    /// <summary>
    /// Base class for Mobile UI Buttons. This class should be expanded for additional implementations for other buttons
    /// </summary>
    /// @author Hanzalah Ravat
    public class MobileButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {

        private List<IButtonListener> _buttonListeners;

        /// <summary>
        /// Default Image Sprite. Used when the button is depressed
        /// </summary>
        public Image ButtonSprite;

        private bool isPressed;

        private void Awake()
        {
            _buttonListeners = new List<IButtonListener>();
        }

        public void AddListener(IButtonListener listener)
        {
            _buttonListeners.Add(listener);
        }

        /// <summary>
        /// Event that is triggered when the poly is clicked.
        /// </summary>
        public void OnPointerDown(PointerEventData eventData)
        {
            isPressed = true;
            foreach (var buttonListener in _buttonListeners)
            {
                buttonListener.onButtonPressed();
            }
        }

        /// <summary>
        /// Event to be triggered when the poly is released
        /// </summary>
        public void OnPointerUp(PointerEventData eventData)
        {
            isPressed = false;

            foreach (var buttonListener in _buttonListeners)
            {
                buttonListener.onButtonReleased();
            }
        }
    }
}