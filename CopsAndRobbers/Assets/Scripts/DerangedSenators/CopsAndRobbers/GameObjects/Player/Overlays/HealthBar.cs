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
using UnityEngine;
using UnityEngine.UI;



namespace DerangedSenators.CopsAndRobbers.GameObjects.Player.Overlays
{
    /// <summary>
    /// This script handles the health bar UI
    /// </summary>
    /// @authors Piotr Krawiec and Hannah Elliman
    public class HealthBar : MonoBehaviour
    {
        public PlayerHealth health;
        public Image healthBarImage;

        public void Update()
        {
            try
            {
                healthBarImage.fillAmount = health.currentHealth / health.maxHealth;
            }
            catch (NullReferenceException ex)
            {
            }
        }
    }
}