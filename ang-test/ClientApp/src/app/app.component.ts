import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  public contacts: contacts[] = [];

  constructor
    (http: HttpClient,
    @Inject('BASE_URL') baseUrl: string,
    public dialog: MatDialog)
  {
    http.get<contacts[]>(baseUrl + 'contacts').subscribe(result => {
      this.contacts = result;
      //console.log(result);
    }, error => console.error(error));
  }


  openDialog(str: string) {
    this.dialog.open(DialogDataWindow, {
      data: {
        adr: str,
      },

    });
  }


  }


@Component({
  template: `<h1 mat-dialog-title>Address is: {{data.adr}}</h1>`,

})
export class DialogDataWindow {
  constructor(@Inject(MAT_DIALOG_DATA) public data: DialogData) { }
}

export interface DialogData {
  adr : string;
}

interface contacts {
  name: string;
  address: string;
}






