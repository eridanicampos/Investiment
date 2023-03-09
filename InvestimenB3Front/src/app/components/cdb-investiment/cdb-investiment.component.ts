import { Component, OnInit, ViewChild} from '@angular/core';
import { FormGroup,NgForm,FormBuilder,Validators } from '@angular/forms';
import { MyErrorStateMatcher } from 'src/app/models/MyErrorStateMatcher';
import { ActivatedRoute } from '@angular/router';
import { MatSnackBar } from '@angular/material/snack-bar';
import { UserService } from 'src/app/services/user.service';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-cdb-investiment',
  templateUrl: './cdb-investiment.component.html',
    styleUrls: ['./cdb-investiment.component.css']
})

export class CdbInvestimentComponent implements OnInit {
  frm!:FormGroup;
  result: string | undefined;
    @ViewChild("userForm") usrForm!:NgForm; 
    get f(){
      return this.frm.controls;
     }
     errorMatcher= new MyErrorStateMatcher();

     constructor(private http: HttpClient,private fb:FormBuilder,private route:ActivatedRoute,
      private userService:UserService,private snackBar: MatSnackBar){
     }
    
     ngOnInit(): void {
      this.frm= this.fb.group({
        amount:['',Validators.required,Validators.pattern('[0-9]'),Validators.pattern('^(?!0\,00)[1-9]\d{0,2}(.\d{3})*(\,\d\d)?$')],
        months:['',[Validators.required,Validators.maxLength(3),Validators.pattern('[0-9]')]]
      })
    }

    calcularInvestimento() {
        const investimentCDBModel = {
            amount: this.frm.controls['amount'].value,
            months: this.frm.controls['months'].value
        }
        // this.userService.cdbInvestment(investimentCDBModel).subscribe({
        //   next:(data)=>{   
        //     var resposta = data.toString();
        //     this.result = resposta.toLocaleString();
        //   },
        //   error:(err)=>{
        //     console.log(err);
        //     this.snackBar.open("error",'close',{
        //       duration:3000
        //     })
        //   }
         // }
        // )

        this.http.post('http://localhost:4200/' + 'CDB/calcularInvestimento', investimentCDBModel).subscribe(
          (response: any) => {
             var resposta = response;
              this.result = resposta.toLocaleString('pt-br', { style: 'currency', currency: 'BRL' });
          },
          (error: any) => {
              console.error(error);
          }
      );

    }

}
