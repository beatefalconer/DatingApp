import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';
import { responseHooks } from 'insomnia-plugin-save-variables';
import { User } from '../_models/user';
import { AccountService } from '../_services/account.service';
//import { EventEmitter } from 'stream';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  //@Input() usersFromHomeComponent: any;
  @Output() cancelRegister = new EventEmitter(); 
  model: any = {};

  constructor(private accountService: AccountService) { }

  ngOnInit(): void {
  }

  register(model: any) {
    return this.accountService.register(this.model).subscribe({
      next: response => {
        //console.log(response);
        this.cancel();
      },
      error: error => {console.log(error),
      console.log(error)}
    })
  }

  cancel () {
    //console.log('cancelled');
    this.cancelRegister.emit(false);
  }
}
