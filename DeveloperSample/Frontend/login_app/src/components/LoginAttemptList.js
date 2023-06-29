import { useState } from "react";
import "./LoginAttemptList.css";

export const LoginAttemptList = ({ loginAttempts, setLoginAttempts }) => {

    const [filteredLogins, setFilteredLogins] = useState(loginAttempts);

    console.log("filteredAttempts");
    console.log(filteredLogins);

    function handleFilter(event) {
        setFilteredLogins(loginAttempts.filter(loginAttempt => loginAttempt.username === event.target.value));
        console.log(event.target.value);
    }

    return (

        <div className="Attempt-List-Main">
            <p>Recent activity</p>
            <input onChange={handleFilter} type="input" id="filter" placeholder="Filter..." />
            <ul className="Attempt-List">
                {filteredLogins.map(loginAttempt => {
                    const { username, pass } = loginAttempt
                    return (
                        <li key={username}>
                            {username} - {pass}
                        </li>
                    )
                })}
            </ul>
        </div>
    )
}
