import "./LoginAttemptList.css";

export const LoginAttemptList = ({loginAttempts, setLoginAttempts}) => {

  console.log(loginAttempts);
  return (

	<div className="Attempt-List-Main">
	 	<p>Recent activity</p>
	  	<input type="input" placeholder="Filter..." />
		<ul className="Attempt-List">
            { loginAttempts.map((loginAttempt) => (
            <li key={loginAttempt.username}>
                <span>{loginAttempt.username}</span>
            </li>
            )) }
		</ul>
	</div>
  )
}
