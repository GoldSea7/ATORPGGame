using AnyRPG;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnyRPG {
    public class CopyGameMenuController : WindowContentController {

        /*
        [SerializeField]
        private HighlightButton noButton = null;

        [SerializeField]
        private HighlightButton yesButton = null;
        */

        // game manager references
        private UIManager uIManager = null;
        private LoadGameManager loadGameManager = null;

        public override void Configure(SystemGameManager systemGameManager) {
            //Debug.Log("CopyGameMenuController.Configure()");
            base.Configure(systemGameManager);

            //noButton.Configure(systemGameManager);
            //yesButton.Configure(systemGameManager);

        }

        public override void SetGameManagerReferences() {
            base.SetGameManagerReferences();
            uIManager = systemGameManager.UIManager;
            loadGameManager = systemGameManager.LoadGameManager;
        }

        public void CancelAction() {
            //Debug.Log("CopyGameMenuController.CancelAction()");
            uIManager.copyGameMenuWindow.CloseWindow();
        }

        public void ConfirmAction() {
            //Debug.Log("CopyGameMenuController.ConfirmAction()");
            loadGameManager.CopyGame();
        }

    }

}