import React, { Component } from 'react';
class LeftBox extends Component{
    
    render(){
        return(
            <div className='col-md m-5' id='main-label'>
                <input type='text' className="form-control form-control-md" onChange={this.props.LeftBox} />
                <select name="measurementType" id="measurementType" className='form-control'  onChange={this.props.selectTypeLeft}>
                <option value="-1" selected>Select</option>
                
                {
                    this.props.showType?
                    <>
                <option name="length">Feet</option>
                <option name="length">Inch</option>
                <option name="length">Meter</option>
                <option name="length">Centimeter</option></> : <>
                <option name="weight">Kilogram</option>
                <option name="weight">Gram</option>
                </>
                }
                </select>
            </div>
        )
    }
}
export default LeftBox;