import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent implements OnInit {

  loginForm!: FormGroup;
  constructor(private fb: FormBuilder) { }

  ngOnInit(): void {

    this.loginForm = this.fb.group({
      username: [''],
      password: ['']
    });
  }

  onSubmit(): void{
    if(this.loginForm.valid)
    {
        //Авторизация прошла 
        console.log(this.loginForm.value);
    }
    else
    {
        //Иди нахуй
        console.log("Иди нахуй");
    }
  }
}
