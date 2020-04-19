import React, { Component } from 'react';
import axios from 'axios';

export default class EmployeeData extends EmployeeData {
    constructor(props) {
        super(props)
        this.state = {
            employee: []
        }
    }
    componentDidMount()
    {
        axios.get("https://localhost:44338/api/Values/GetAllEmployee")
        .then(response=>{
            console.log(response)
            const employee = response.data;
            this.setState({
                employee:employee
            })
            if(response == null)
            {
                document.getElementById("record").hidden = false;
            }
        })
    }

    deleteEntryHandler=(emp_id)=>{
        console.log(emp_id);
    if(window.confirm("Are you sure"))
    {
      axios.delete('https://localhost:44338/api/Values/DeleteEmployee/',{ params: { emp_id } })
      .then(response=>{
          console.log(response.data);
          this.refereshEntriesHandler();
        })
    }
    }

    render() {
        return (
            <>
                <div className="contain">  
                    <p id="lk" href="http://localhost:3000/login">Login</p>
                </div>
                <div className="container_first">
                    <p id="record" hidden>No Record Found!!</p>
                </div>
                <div className="container_next">
                <p><button>Add Employee</button></p> 
                </div>
                <div className="container_second">
                    <table className="table">
                    <thead>
                        <tr>
                            <th>Firstname</th>
                            <th>Lastname</th>
                            <th>Email</th>
                            <th>Edit</th>
                            <th>Delete</th>
                        </tr>
                        </thead>
                        <tbody id="tabledata">
                            {
                                this.state.employee.map(emp => 
                                    <tr key={emp.emp_id}>
                                        <td>{emp.firstName}</td>
                                        <td>{emp.lastName}</td>
                                        <td>{emp.email}</td>
                                        <td><button>Edit</button></td>
                                        <td><button onClick={()=>{this.deleteEntryHandler(emp.emp_id)}}>Delete</button></td>
                                    </tr>
                                )
                            }

                        </tbody>
                    </table>
                </div>
            </>
        )
    }
}